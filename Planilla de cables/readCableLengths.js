const ExcelJS = require("exceljs");
//const cableLengths = require("./readCableLengths.js");

function read_lengths(filename, changed_lengths) {

    var workbook = new ExcelJS.Workbook();
    return workbook.xlsx.readFile(filename)
    .then(function() {
        return getData(workbook, changed_lengths);
    })
}

function getData(workbook, changed_lengths) {

    // console.log(JSON.stringify((changed_lengths.replaceAll("\"", "")).split(";")));

    var list_changed_lengths = (((changed_lengths.replaceAll("\"", "")).replaceAll("[","")).replaceAll("]","")).split(";");
    
    for(var i = 0; i < list_changed_lengths.length; i++) {
        list_changed_lengths[i] = list_changed_lengths[i].split(",");
        console.log(list_changed_lengths[i]);
    } 

    console.log(JSON.stringify(list_changed_lengths));

    // text.split(" ");

    var origin_B = false;
    var new_data = new Object();

    for(var k = 0; k < 3; k++) {
        var worksheet = workbook.worksheets[k];

        for(var i = 3; i <= 45; i++) {
            if(new_data[worksheet.getCell(i,1).value] == undefined) {
                new_data[worksheet.getCell(i,1).value] = new Object();

                if((worksheet.getCell(i,1).value).indexOf("B") >= 0) {
                    new_data[(worksheet.getCell(i,1).value).replace("B", "H")] = new Object();
                    origin_B = true;
                }
            }

            for(var j = 2; j <= 44; j++) {
                if(worksheet.getCell(i,j).value.result != undefined) {
                    new_data[worksheet.getCell(i,1).value][worksheet.getCell(2,j).value] = Math.round(worksheet.getCell(i,j).value.result*100)/100;
                    
                    if((worksheet.getCell(2,j).value).indexOf("B") >= 0) {
                        new_data[worksheet.getCell(i,1).value][(worksheet.getCell(2,j).value).replace("B", "H")] = Math.round(worksheet.getCell(i,j).value.result*100)/100;
                    }

                    if(origin_B) {
                        new_data[(worksheet.getCell(i,1).value).replace("B", "H")][worksheet.getCell(2,j).value] = Math.round(worksheet.getCell(i,j).value.result*100)/100;
                        if((worksheet.getCell(2,j).value).indexOf("B") >= 0) {
                            new_data[(worksheet.getCell(i,1).value).replace("B", "H")][(worksheet.getCell(2,j).value).replace("B", "H")] = Math.round(worksheet.getCell(i,j).value.result*100)/100;
                        }
                    }
                } else {
                    new_data[worksheet.getCell(i,1).value][worksheet.getCell(2,j).value] = Math.round(worksheet.getCell(i,j).value*100)/100;

                    if((worksheet.getCell(2,j).value).indexOf("B") >= 0) {
                        new_data[worksheet.getCell(i,1).value][(worksheet.getCell(2,j).value).replace("B", "H")] = Math.round(worksheet.getCell(i,j).value*100)/100;
                    }

                    if(origin_B) {
                        new_data[(worksheet.getCell(i,1).value).replace("B", "H")][worksheet.getCell(2,j).value] = Math.round(worksheet.getCell(i,j).value*100)/100;
                        if((worksheet.getCell(2,j).value).indexOf("B") >= 0) {
                            new_data[(worksheet.getCell(i,1).value).replace("B", "H")][(worksheet.getCell(2,j).value).replace("B", "H")] = Math.round(worksheet.getCell(i,j).value*100)/100;
                        }
                    }
                }
            }
        }
    }   

    for(var j = 0; j < list_changed_lengths[0].length; j++) {

        console.log("Previous value of origin: " + list_changed_lengths[0][j] + " and value of destination: " + list_changed_lengths[1][j] + " and value of length: " + list_changed_lengths[2][j]);

        console.log("Origin is not null: " + (list_changed_lengths[0][j] != ""));
        console.log("Destination is not null: " + (list_changed_lengths[1][j] != ""));
        console.log("Length is a number: " + (isValidNumber(list_changed_lengths[2][j])));

        if((list_changed_lengths[0][j] != "")&&(list_changed_lengths[1][j] != "")&&(isValidNumber(list_changed_lengths[2][j]))) {

            console.log("Value of origin: " + list_changed_lengths[0][j] + " and value of destination: " + list_changed_lengths[1][j] + " and value of length: " + list_changed_lengths[2][j]);

            var count_i = 5000;

            while(count_i > 0) {
                console.log("after_i");
                count_i -= 1;
            }

            // new_data[list_changed_lengths[0][j]][list_changed_lengths[1][j]] = Math.round([list_changed_lengths[2][j]]*100)/100;
            new_data[list_changed_lengths[0][j]][list_changed_lengths[1][j]] = Math.round([list_changed_lengths[2][j]]*100)/100 + new_data[list_changed_lengths[0][j]][list_changed_lengths[1][j]];

            var count_j = 5000;

            while(count_j > 0) {
                console.log("after_j");
                count_j -= 1;
            }

            if((list_changed_lengths[1][j]).indexOf("B") >= 0) { 
                // new_data[list_changed_lengths[0][j]][list_changed_lengths[1][j].replace("B", "H")] = Math.round([list_changed_lengths[2][j]]*100)/100;
                new_data[list_changed_lengths[0][j]][list_changed_lengths[1][j].replace("B", "H")] = Math.round([list_changed_lengths[2][j]]*100)/100 + new_data[list_changed_lengths[0][j]][list_changed_lengths[1][j].replace("B", "H")];
            }

            var count_k = 5000;

            while(count_k > 0) {
                console.log("after_k");
                count_k -= 1;
            }

            if((list_changed_lengths[0][j]).indexOf("B") >= 0) {
                // new_data[list_changed_lengths[0][j].replace("B", "H")][list_changed_lengths[1][j]] = Math.round([list_changed_lengths[2][j]]*100)/100;
                new_data[list_changed_lengths[0][j].replace("B", "H")][list_changed_lengths[1][j]] = Math.round([list_changed_lengths[2][j]]*100)/100 + new_data[list_changed_lengths[0][j].replace("B", "H")][list_changed_lengths[1][j]];

                if((list_changed_lengths[1][j]).indexOf("B") >= 0) {
                    // new_data[list_changed_lengths[0][j].replace("B", "H")][list_changed_lengths[1][j]] = Math.round([list_changed_lengths[2][j]]*100)/100;
                    new_data[list_changed_lengths[0][j].replace("B", "H")][list_changed_lengths[1][j]] = Math.round([list_changed_lengths[2][j]]*100)/100 + new_data[list_changed_lengths[0][j].replace("B", "H")][list_changed_lengths[1][j]];
                }
            }

            var count_l = 5000;

            while(count_l > 0) {
                console.log("after_l");
                count_l -= 1;
            }
            
        }
        else if ((list_changed_lengths[0][j] != "")&&(list_changed_lengths[1][j] == "")&&(isValidNumber(list_changed_lengths[2][j]))) {           
            var count_l = 5000;

            while(count_l > 0) {
                console.log("print_NO DESTINATION");
                count_l -= 1;
            }
        }
        else if ((list_changed_lengths[0][j] == "")&&(list_changed_lengths[1][j] != "")&&(isValidNumber(list_changed_lengths[2][j]))) {           
            var count_l = 5000;

            while(count_l > 0) {
                console.log("print_NO ORIGIN");
                count_l -= 1;
            }
        }

    }

    return new_data;
}

function isValidNumber(n){
    console.log("IsValidNumber: " + n);
    // return (Number(n)=== n && (Number(n) > 0));
    // return /^-?\\d*(\\.\\d+)?$/.test(n);
    return !isNaN(n);
    // return parseFloat(n) > 0;
}

exports.read_lengths = read_lengths;













