if exist "C:\Program Files\nodejs\" (
   echo Se termino la instalacion.
   pause
) else (
     if exist "node-v18.16.0-x64.msi" (	
	echo Instalamos NodeJS
	msiexec.exe /i node-v18.16.0-x64.msi
	npm i excel4node
	npm i exceljs
	echo Se termino la instalacion.
	pause
     ) else (
	echo No se pudo encontrar el archivo de instalacion
	pause
     )
)


