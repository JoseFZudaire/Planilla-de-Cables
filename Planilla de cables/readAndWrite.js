const ExcelJavascript = require("./read_exceljs.js");
const writeFile = require("./write_excel4node.js");

var path_lengths = "C:\\Users\\JZ4874\\Documents\\HE Desarrollo - Repo\\HE_Des\\018 - Cálculo de longitud de cable Fábrica\\Distancias de Cables VA.xlsx";

readAndWrite();

async function readAndWrite() {

    console.log("\n-----------------------------\nREADING DATA\n-------------------------------\n");
    var data = await ExcelJavascript.read_file(process.argv[2], process.argv[4]);
    console.log("\n-----------------------------\nPRINTING DATA\n-------------------------------\n");
    writeFile.print_values(data, process.argv[3]);
    
}
