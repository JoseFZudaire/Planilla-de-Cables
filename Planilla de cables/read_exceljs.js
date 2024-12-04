const ExcelJS = require("exceljs");
const cableLengths = require("./readCableLengths.js");

var block_nbr = 0;
var seniales = {};

var lengthCables;

// read_file("C:\\Users\\JZ4874\\Downloads\\CAMBIOS_TAGE_REV.C1.xlsx");
// read_file("C:\\Users\\JZ4874\\Documents\\HE Desarrollo - Repo\\HE_Des\\013 - Planilla para corte de cables\\PLANILLAS DE CABLES\\Q220022-71212.xlsx");

async function read_file(filename, changed_lengths) {

    var path_lengths = __filename.split('Planilla de cables')[0] + "\\Planilla de cables\\Distancias de Cables VA.xlsx";

    var cable_lengths = await cableLengths.read_lengths(path_lengths, changed_lengths);

    lengthCables = cable_lengths;

    var workbook = new ExcelJS.Workbook();
    return workbook.xlsx.readFile(filename)
        .then(function() {

            var section_nbr = new Object();

            for(let i = 0; i < workbook.worksheets.length; i++) {

                const worksheet = workbook.worksheets[i];
    
                if(worksheet.getCell(3,10).value == "Conexionado") {
                    var data = new Object();
    
                    for(let j = 8; j < 78; j++) {
                        if(worksheet.getCell(j,3).value != null) {

                            data = getData(j, worksheet);

                            if (seniales[data.el_1] == undefined) {
                                block_nbr++;
                                section_nbr[data.el_1 + data.el_5 + data.section] = 1;
                                data.nbr = section_nbr[data.el_1 + data.el_5 + data.section];

                                seniales[data.el_1] = {};
                                seniales[data.el_1][data.el_5] = {};
                                seniales[data.el_1][data.el_5][data.section] = {};
                                seniales[data.el_1][data.el_5][data.section][data.el_2] = {};
                                seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6] = [];
                                seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6].push([data]);
                            }
                            else if(seniales[data.el_1][data.el_5] == undefined) {
                                block_nbr++;
                                section_nbr[data.el_1 + data.el_5 + data.section] = 1;
                                data.nbr = section_nbr[data.el_1 + data.el_5 + data.section];
                                seniales[data.el_1][data.el_5] = {};
                                seniales[data.el_1][data.el_5][data.section] = {};
                                seniales[data.el_1][data.el_5][data.section][data.el_2] = {};
                                seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6] = [];
                                seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6].push([data]);
                            }
                            else if(seniales[data.el_1][data.el_5][data.section] == undefined) {
                                block_nbr++;
                                section_nbr[data.el_1 + data.el_5 + data.section] = 1;
                                data.nbr = section_nbr[data.el_1 + data.el_5 + data.section];
                                seniales[data.el_1][data.el_5][data.section] = {};
                                seniales[data.el_1][data.el_5][data.section][data.el_2] = {};
                                seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6] = [];
                                seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6].push([data]);
                            }
                            else if(seniales[data.el_1][data.el_5][data.section][data.el_2] == undefined) {
                                block_nbr++;
                                section_nbr[data.el_1 + data.el_5 + data.section]++;
                                data.nbr = section_nbr[data.el_1 + data.el_5 + data.section];
                                seniales[data.el_1][data.el_5][data.section][data.el_2] = {};
                                seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6] = [];
                                seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6].push([data]);
                            }
                            else if(seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6] == undefined) {
                                block_nbr++;
                                section_nbr[data.el_1 + data.el_5 + data.section]++;
                                data.nbr = section_nbr[data.el_1 + data.el_5 + data.section];
                                seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6] = [];
                                seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6].push([data]);
                            }

                            else if(seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6].length > 0) {
                                var new_array = true;
                                for(var k = 0; k < seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6].length; k++) {

                                    if((seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6][k].length < 6) &&
                                        (!seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6][k].map(el => el.el_4)
                                                .includes(data.el_4))) {

                                        seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6][k].push(data);
                                        new_array = false;

                                        break;
                                    }
                                }
                                if(new_array) {
                                    block_nbr++;
                                    
                                    section_nbr[data.el_1 + data.el_5 + data.section]++;
                                    data.nbr = section_nbr[data.el_1 + data.el_5 + data.section];
                                    seniales[data.el_1][data.el_5][data.section][data.el_2][data.el_6].push([data]);

                                }
                            }
                            else {
                                console.log("Hubo un error");
                            }
                        }                        
                    }
                }
            }       
            // console.log("Señales: " + JSON.stringify(seniales));  
            return seniales;
        });
}

function getString(str) {
    if(typeof str === 'string' || str instanceof String) {
        return str;
    } else if(str == null) {
        return "";
    } else {
        return str.toString();
    }
}

function getData(row, worksheet) {
    var new_data = new Object();

    const isRele = str => /[+-][^U].*\..*/.test(str);
    const isKBornera = str => /[+-]K.*/.test(str);
    const isLocationOriginOrDestination = str => /[15]/.test(str);
    const isBorneraOriginOrDestination = str => /[26]/.test(str);

    new_data.el_1 = getString(worksheet.getCell(row,3).value);
    new_data.el_2 = getString(worksheet.getCell(row,4).value);
    new_data.el_3 = getString(worksheet.getCell(row,5).value);
    new_data.el_4 = getString(worksheet.getCell(row,2).value);
    // console.log("Value of cell(" + row + ",2) is " + worksheet.getCell(row,2).value);
    new_data.el_5 = getString(worksheet.getCell(row,6).value);
    new_data.el_6 = getString(worksheet.getCell(row,7).value);
    new_data.el_7 = getString(worksheet.getCell(row,8).value);
    new_data.location = worksheet.getCell(3,3).value;
    new_data.sublocation = worksheet.getCell(4,3).value;
    new_data.section = worksheet.getCell(row,9).value;
    new_data.project = worksheet.getCell(80,5).value;
    new_data.device = "";

    if((new_data.el_1 != null)&&(lengthCables[(new_data.el_1).replace("+", "")] != undefined)) {
        if((new_data.el_5 != null)&&(lengthCables[(new_data.el_1).replace("+", "")][(new_data.el_5).replace("+", "")] != undefined)) {
            new_data.length = "L: " + lengthCables[(new_data.el_1).replace("+", "")][(new_data.el_5).replace("+", "")] + " m";
        } else {
            new_data.length = "L: ";
        }
    } else {
        new_data.length = "L: ";
    }
    
    new_data.nbr = String(block_nbr);

    for(var i = 7; i > 0; i--) {

        new_data["el_" + i + "_value"] = new_data["el_" + i];

        if(isLocationOriginOrDestination(i)) {
            if(isRele(new_data["el_" + i])) {
                var array_names =  new_data["el_" + i].split(".");
                new_data["el_" + i] = array_names[0];
                new_data["el_" + (i+1)] = "";
            }
        }       

        if(isBorneraOriginOrDestination(i)) {
            if(isKBornera(new_data["el_" + i])) {
                var array_names =  new_data["el_" + i].split("K");
                new_data["el_" + i] = array_names[0];
                new_data["el_" + (i+1)] = "";
            }
        }
    }

    return new_data;
}

exports.read_file = read_file;




