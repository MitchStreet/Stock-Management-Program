
![Logo](https://github.com/MitchStreet/Stock-Management-Program/blob/main/readme_title.png?raw=true)


### Stock Management program
Designed with barcodes scanners and serial numbers in mind. Developed in solely C# using WinForms from Microsoft.


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

<img src="https://github.com/MitchStreet/Stock-Management-Program/blob/main/install%20tutorial.gif?raw=true" width="50%" height="50%">

After downloading the .zip from the latest release and extracting the file, to run the program for the first time navigate to the following file:

```bash
  <Download location>\Stock Management Program\bin\Debug\net6.0-windows\Stock Management Program.exe
```

Running this .exe will load up the program for the first time, the option to **make a shortcut to open the program** is available in the settings page as the top-right option.

## Updates

Updating the software on a new release is as easy as replacing your current file with the new file. As the file structure will remain the same, your shortcut should still workas long as the location of the folder doesn't change.

## 📷 Usage and Screenshots 📷

### Single serial number scan in
<img src="https://github.com/MitchStreet/Stock-Management-Program/blob/main/Single%20barcode%20scan%20in.gif?raw=true" width="40%" height="40%">

An example of how a single barcode would be scanned into the system.

### Bulk / multiple serial number scan in
<img src="https://github.com/MitchStreet/Stock-Management-Program/blob/main/Bulk%20barcode%20scan%20in.gif?raw=true" width="40%" height="40%">

An example of how multiple or 'bulk' barcodes would be scanned into the system.

### Scan in options
<img src="https://github.com/MitchStreet/Stock-Management-Program/blob/main/scan%20in%20serial%20num%20options.png?raw=true" width="40%" height="40%">

The user has the option between: normally scanning in the serial numbers and barcodes where everytime the 'Store' button is pressed, the optional information is reset - the situation this would be used in, is when single items are being scanned in at a time with different information attached to each of them. The other option available to the user is a 'Bulk mode' where the optional information is saved past each store and can be reused on the next item; used in conjunction with the 'Alt key' option the user can scan in items on mass with only a barcode scanner!

<img src="https://github.com/MitchStreet/Stock-Management-Program/blob/main/scan%20in%20alt%20key.png?raw=true" width="40%" height="40%">

The 'Alt key' option makes it so the 'Enter' or 'Return' key presses the submit button. Some barcode scanners have the feature of simulating pressing the enter key after scanning a code, so the program supports these scanners by submitting the barcode as its scanned with the optional information automatically applied - for barcode scanners that lack that feature, don't worry! Pressing the enter key on the keyboard presses the 'Store' key when the option is enabled.

## Database method

Data was stored using .csv files.

<img src="https://www.iconpacks.net/icons/2/free-csv-icon-1518-thumb.png" width="8%" height="8%">

As an extremely versatile file type, .CSVs can be used in a wide variety of programs. To ensure that in the case of a user wanting to migrate their data to another program or utilise their data in a way the program doesn't allow them to, storing the data as .CSVs guarantees they can do so without losing any data due to a storage method with limited usability.

## Utilised by:

This software is used by:

- The Christie NHS Trust



## Authors

- [Mitchell Jay Street](https://www.github.com/MitchStreet)

