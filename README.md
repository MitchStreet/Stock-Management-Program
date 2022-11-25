
![Logo](https://github.com/MitchStreet/Stock-Management-Program/blob/main/readme_title.png?raw=true)


### Stock Management program
Designed with barcodes scanners and serial numbers in mind.


## Details

👨‍💻 A program that allows the user to store and manage scanned in stock through the use of barcodes and barcode scanners. 👨‍💻

The program is GUI based and provides two main functionalities: 
- Scan in stock
- Manage scanned in stock

### Features and purpose
The program’s purpose is to track and manage stock, the following points summarise the user requirements for this specific program:
-   Scan in stock
-	Add to existing category
-	Add new category
-	Select / enter new category
- Manage stock
- Manage categories

The program then needs to validate if the barcode already exists in the selected category and give relevant options on what to do.

-   Manage stock
-	Display existing categories / models
-	User can select from options displayed
-	Display relevant serial numbers from selected area
-	User can select serial number from list
With the selected serial number, the user can: allocate it to a customer and allow them to assign a order number to it or revert the serial number from being allocated to regular old ‘stocked’ and remove the assigned order number.


## Installation

### Requirements:
[**.NET Desktop Runtime**](https://download.visualstudio.microsoft.com/download/pr/0192a249-3ec8-4374-a827-e186dd58d55d/cec046575f3eb2247a10ba3d50f5cf6c/windowsdesktop-runtime-6.0.11-win-x64.exe ".NET Desktop Runtime") is required to run this application.


After downloading the .zip and extracting the file, to run the program for the first time navigate to the following file:

```bash
  <Download location>\Stock Management Program\bin\Debug\net6.0-windows\Stock Management Program.exe
```

Running this .exe will load up the program for the first time, the option to **make a shortcut to open the program** is available in the settings page as the top-right option.

## 📷 Usage and Screenshots 📷

### Single serial number scan in
![Single scan in](https://github.com/MitchStreet/Stock-Management-Program/blob/main/Single%20barcode%20scan%20in.gif?raw=true)

An example of how a single barcode would be scanned into the system.

### Bulk / multiple serial number scan in
![Bulk scan in](https://github.com/MitchStreet/Stock-Management-Program/blob/main/Bulk%20barcode%20scan%20in.gif?raw=true)

An example of how multiple or 'bulk' barcodes would be scanned into the system.

### Scan in options
![Scan in options](https://github.com/MitchStreet/Stock-Management-Program/blob/main/scan%20in%20serial%20num%20options.png?raw=true)

The user has the option between: normally scanning in the serial numbers and barcodes where everytime the 'Store' button is pressed, the optional information is reset - the situation this would be used in, is when single items are being scanned in at a time with different information attached to each of them. The other option available to the user is a 'Bulk mode' where the optional information is saved past each store and can be reused on the next item; used in conjunction with the 'Alt key' option the user can scan in items on mass with only a barcode scanner!

![Scan in alt key](https://github.com/MitchStreet/Stock-Management-Program/blob/main/scan%20in%20alt%20key.png?raw=true)

The 'Alt key' option makes it so the 'Enter' or 'Return' key presses the submit button. Some barcode scanners have the feature of simulating pressing the enter key after scanning a code, so the program supports these scanners by submitting the barcode as its scanned with the optional information automatically applied - for barcode scanners that lack that feature, don't worry! Pressing the enter key on the keyboard presses the 'Store' key when the option is enabled.


## Utilised by:

This software is used by

- The Christie NHS Trust



## Authors

- [Mitchell Jay Street](https://www.github.com/MitchStreet)

