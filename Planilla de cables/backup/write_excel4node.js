const excel = require("excel4node");

let first_row = 2;
let first_col = 1;

var section_and_destination = [null];

var section_lengths = new Object();

const workbook = new excel.Workbook();

const center_text = workbook.createStyle({
    alignment: {wrapText: true, horizontal: 'center'}
});

const bold_text = workbook.createStyle({
    font: {bold: true, name: 'Arial', size: 10}
});

const top_thick = workbook.createStyle({
    font: { color: '#000000', size: 10, name: 'Arial'},
    border: { top: { style: 'medium', color: '#000000' } }
});

const bottom_thick = workbook.createStyle({
    font: { color: '#000000', size: 10, name: 'Arial'},
    border: { bottom: { style: 'medium', color: '#000000' } }
});

const left_thick = workbook.createStyle({
    font: { color: '#000000', size: 10, name: 'Arial'},
    border: { left: { style: 'medium', color: '#000000' } }
});

const right_thick = workbook.createStyle({
    font: { color: '#000000', size: 10, name: 'Arial'},
    border: { right: { style: 'medium', color: '#000000' } }
});

const top_dashed = workbook.createStyle({
    font: { color: '#000000', size: 10, name: 'Arial'},
    border: { top: { style: 'dotted', color: '#000000' } }
});

const bottom_dashed = workbook.createStyle({
    font: { color: '#000000', size: 10, name: 'Arial'},
    border: { bottom: { style: 'dotted', color: '#000000' } }
});

const left_dashed = workbook.createStyle({
    font: { color: '#000000', size: 10, name: 'Arial'},
    border: { left: { style: 'dotted', color: '#000000' } }
});

const right_dashed = workbook.createStyle({
    font: { color: '#000000', size: 10, name: 'Arial'},
    border: { right: { style: 'dotted', color: '#000000' } }
});

const left_line_grey = workbook.createStyle({
    font: { color: '#000000', size: 10, name: 'Arial'},
    border: { left: { style: 'thin', color: '#D3D3D3' } }
});

const bottom_line_grey = workbook.createStyle({
    font: { color: '#000000', size: 10, name: 'Arial'},
    border: { bottom: { style: 'thin', color: '#D3D3D3' } }
});

const available_colors = ["#FFFFFF", "#1BA552", "#e2c2c5", "#F4D03F", "#C88FE2", "#12F776", "#12F723", "#7F8C8D", 
                    "#904786", "#a48da4", "#947298", "#E7EC7B", "#af7564", "#2749F7", "#50626e", "#c0dfec", "#b89eae", "#63EA98", 
                    "#c6b2c0", "#F0BB6F", "#6b7c84", "#488556", "#DDF660", "#a94952", "#f9ebd2", "#10AC55", "#926b6b", "#638187", 
                    "#C3E12C", "#62EA9E", "#5DA57D", "#987289", "#575567", "#12CBDA", "#36D876", "#c0ece3", "#E87AD9", "#829E59", 
                    "#2980B9", "#c38370", "#8E44AD", "#728998", "#667b88", "#77F780", "#E74C3C", "#9D753B", "#87B2B5", "#9147B4", 
                    "#e6ebed", "#9295a9", "#CAC0C0", "#869ca5", "#E5A0A0", "#c0ece3", "#C3E12C", "#687BDB", "#DF901E", "#9ca586", 
                    "#4C8A65", "#980ED8", "#F5B041", "#5E9016", "#C0CAC2", "#545C91", "#25595D", "#0026E4", "#C7EC91", "#58D68D", 
                    "#9B8F8F", "#AEB163", "#9A5858", "#b79696", "#95D836", "#86a58f", "#44525b", "#77F780", "#868da5", "#3498DB"
                ];


const worksheet = workbook.addWorksheet("Cableado");
const worksheet_nombres = workbook.addWorksheet("Nombres");
const worksheet_calculos = workbook.addWorksheet("Calculos");


var row_lower_sections = 3;
var row_higher_sections = 3;

var col_sections = 0;

function print_values(block_array, save_path) {

    var index_value = 0;
    var index_section = 0;

    var empty_data = new Object();

    worksheet_nombres.cell(1, 4).string("2.5 mm2, 4 mm2");
    worksheet_nombres.cell(1, 2).string("1 mm2, 1.5 mm2");

    worksheet_nombres.cell(2, 6).string("Valores de secciones");

    for(var [key_origin_1, value_origin_1] of Object.entries(block_array)) { 
        for(var [key_destiny_1, value_destiny_1] of Object.entries(value_origin_1)) {
            for(var [key_section, value_section] of Object.entries(value_destiny_1)) { 
                index_value = 0;
                for(var [key_origin_2, value_origin_2] of Object.entries(value_section)) { 
                    for(var [key_destiny_2, value_destiny_2] of Object.entries(value_origin_2)) { 
                        for(var [key_destiny_2, value_signal_list] of Object.entries(value_destiny_2)) { 
                            index_value++;

                            if(value_signal_list[0].section == null) {
                                value_signal_list[0].section = "";
                            }

                            empty_data.section = value_signal_list[0].section;

                            // empty_data.length = cable_lengths[(value_signal_list[0].length).replace("+", "")];

                            empty_data.length = value_signal_list[0].length;
                            empty_data.project = value_signal_list[0].project;
                            empty_data.device = value_signal_list[0].device;
                            empty_data.location = value_signal_list[0].location;
                            empty_data.sublocation = value_signal_list[0].sublocation;
                            empty_data.color = new Object();
                            empty_data.color.destination = "#FFFFFF";
        
                            var color = getColor(value_signal_list[0]);
                            empty_data.color.section = color.section;
                            value_signal_list[0].nbr += index_section;
                            print_layer(value_signal_list, color);
                        }
                    }
                }

                var remainder = (3 - (index_value % 3)) % 3;
                while(remainder > 0) {
                    index_value++;
                    empty_data.nbr = index_section + index_value;
                    print_layer([empty_data], empty_data.color)
                    remainder--;
                }
         
                index_section += index_value;
            }
        }
    }                  

    var count_row_section = 0;

    for (let key in section_lengths) {
        worksheet_nombres.cell(count_row_section + 3, 6).string(key);
        worksheet_nombres.cell(count_row_section + 3, 7).formula("sum("
            + "Calculos!" + String.fromCharCode(64 + section_lengths[key].col) + section_lengths[key].start_row 
            + ":" 
            + "Calculos!" + String.fromCharCode(64 + section_lengths[key].col) + section_lengths[key].end_row 
            + ")");

        worksheet_nombres.cell(count_row_section + 3, 8).string("m");
        count_row_section++;
    }

    workbook.write(save_path);
}

function getColor(data) {

    var colors = new Object();

    if(!section_and_destination.includes(data.el_5)) {
        section_and_destination.push(data.el_5);
    }

    if(!section_and_destination.includes(data.section)) {
        section_and_destination.push(data.section);
    }

    if(section_and_destination.indexOf(data.el_5) < available_colors.length) {
        colors["destination"] = available_colors[section_and_destination.indexOf(data.el_5)];
    }
    else {
        colors["destination"] = available_colors[0];
    }

    if((section_and_destination.indexOf(data.section) < available_colors.length) && (data.section != null) &&
        ((data.section.includes("2.5")) || (data.section.includes("2,5")) || (data.section.includes("4")))) {
        colors["section"] = available_colors[section_and_destination.indexOf(data.section)];
    }
    else {
        colors["section"] = available_colors[0];
    }

    return colors;
}

function print_layer(block_data, fill_color) {

    var initRow = first_row + (Math.floor((block_data[0].nbr - 1) / 3)*11);
    var initCol = first_col + (((block_data[0].nbr - 1) % 3)*7);

    for(let i = initRow; i < (initRow + 11); i++) {
        worksheet.row(i).setHeight(14.2);
    }

    worksheet.column(initCol).setWidth(6);
    worksheet.column(initCol + 1).setWidth(8);
    worksheet.column(initCol + 2).setWidth(3.55);
    worksheet.column(initCol + 3).setWidth(13);
    worksheet.column(initCol + 4).setWidth(6.55);
    worksheet.column(initCol + 5).setWidth(6.91);
    worksheet.column(initCol + 6).setWidth(3.45);

    worksheet.cell(initRow,initCol).string(block_data[0].nbr.toString())
                .style(center_text)
                .style(bold_text)
                .style(top_thick)
                .style(left_thick)
                .style(right_thick)
                .style(bottom_thick);

    worksheet.cell(initRow,initCol+1,initRow,initCol+6,true).string(block_data[0].location)
                .style(center_text)
                .style(bold_text)
                .style(top_thick)
                .style(right_thick);

    worksheet.cell(initRow+1,initCol,initRow+1,initCol+6,true).string("Tableros")
                .style(center_text)
                .style(bold_text)
                .style(left_thick)
                .style(right_thick);

    worksheet.cell(initRow+2,initCol,initRow+2,initCol+6,true).string(block_data[0].sublocation)
                .style(bold_text)
                .style(center_text)
                .style(left_thick)
                .style(right_thick)
                .style(bottom_thick);

    for(var i = initRow+3; i < initRow+9; i++) {
        for(var j = initCol; j < initCol+7; j++) {
            worksheet.cell(i,j)
                .style(top_dashed)
                .style(left_dashed)
                .style(right_dashed)
                .style(bottom_dashed);
        }
    }

    if(initCol != 1) {
        worksheet.cell(initRow+9,initCol,initRow+9,initCol+2,true).string(block_data[0].length)
                    .formula('A' + (initRow+9))
                    .style(center_text)
                    .style(bold_text)
                    .style(top_thick)
                    .style(left_thick);
    } else {
        worksheet.cell(initRow+9,initCol,initRow+9,initCol+2,true).string(block_data[0].length)
            .style(center_text)
            .style(bold_text)
            .style(top_thick)
            .style(left_thick);
    }

    worksheet.cell(initRow+9,initCol+3).style(top_thick);
    
    worksheet.cell(initRow+9,initCol+4,initRow+9,initCol+6,true).string(block_data[0].section)
                .style(center_text)
                .style(bold_text)
                .style(top_thick)
                .style(right_thick)
                .style(left_line_grey)
                .style(bottom_line_grey)
                .style({fill: {
                    type: 'pattern',
                    patternType: 'solid',
                    fgColor: fill_color.section,
                }});

    worksheet.cell(initRow+10,initCol,initRow+10,initCol+6,true).string(block_data[0].project)
                .style(center_text)
                .style(bold_text)
                .style(bottom_thick)
                .style(left_thick)
                .style(right_thick);

    for(var i = 0; i < block_data.length; i ++) {

        for(var j = 0; j < 7; j++) {
            if(block_data[i]["el_" + (j + 1)] != undefined) {
                worksheet.cell(initRow+3+i,j+initCol).string(block_data[i]["el_" + (j + 1) + "_value"])
                        .style(center_text)
                        .style(bold_text);
                        

                if(j == 4) {
                    worksheet.cell(initRow+3+i,j+initCol)
                            .style({fill: {
                                type: 'pattern',
                                patternType: 'solid',
                                fgColor: fill_color.destination, 
                            }}); 
                }

            }
        }
        if(block_data[i]["el_4"] != undefined) {
            if((block_data[i]["section"] != null) && (block_data[i]["section"].includes("2.5") || block_data[i]["section"].includes("2,5") ||
                block_data[i]["section"].includes("4") || block_data[i]["section"].includes("6"))) {
                
                worksheet_nombres.cell(row_higher_sections, 4).string(block_data[i]["el_4"]);
                row_higher_sections++;             
            } 
            else {
                worksheet_nombres.cell(row_lower_sections, 2).string(block_data[i]["el_4"]);
                row_lower_sections++;
            }
        }
    }

    var formula_block_length = "(6";

    for(var j = 3; j < 9; j++) {
        formula_block_length += " - if(and(exact(Cableado!" + (String.fromCharCode(64 + initCol) + (initRow + j)) + ",\"\")";
        for(var i = 1; i < 7; i++) {
            formula_block_length += ", exact(Cableado!" + (String.fromCharCode(64 + initCol + i) + (initRow + j)) + ",\"\")";
        }
        formula_block_length += "),1,0)";
    }
    formula_block_length += ")";

    if(section_lengths[block_data[0].section] == undefined) {
        section_lengths[block_data[0].section] = new Object();
        col_sections += 2;
        section_lengths[block_data[0].section].col = col_sections;
        section_lengths[block_data[0].section].start_row = 3;
        section_lengths[block_data[0].section].end_row = 4;

        worksheet_calculos.cell(section_lengths[block_data[0].section].start_row, 
            section_lengths[block_data[0].section].col)
            .formula("if(exact(" 
                + "substitute(substitute(substitute(substitute(" 
                + "Cableado!" + (String.fromCharCode(64 + initCol) + (initRow + 9)) 
                + ",\"m\",\"\"),\" \",\"\"),\"L:\",\"\"),\",\",\".\")" 
                +  ", \"\"),0," 
                + "substitute(substitute(substitute(substitute(" 
                + "Cableado!" + (String.fromCharCode(64 + initCol) + (initRow + 9)) 
                + ",\"m\",\"\"),\" \",\"\"),\"L:\",\"\"),\",\",\".\")"
                + ")" 
                + " * " 
                + formula_block_length);
    } else {
        worksheet_calculos.cell(section_lengths[block_data[0].section].end_row, 
            section_lengths[block_data[0].section].col)
            .formula("if(exact(" 
                + "substitute(substitute(substitute(substitute(" 
                + "Cableado!" + (String.fromCharCode(64 + initCol) + (initRow + 9)) 
                + ",\"m\",\"\"),\" \",\"\"),\"L:\",\"\"),\",\",\".\")" 
                +  ", \"\"),0," 
                + "substitute(substitute(substitute(substitute(" 
                + "Cableado!" + (String.fromCharCode(64 + initCol) + (initRow + 9)) 
                + ",\"m\",\"\"),\" \",\"\"),\"L:\",\"\"),\",\",\".\")"
                + ")" 
                + " * " 
                + formula_block_length);

        section_lengths[block_data[0].section].end_row++;
    }
}

exports.print_values = print_values;


