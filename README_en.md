# Order Automizer
###### v1.15 Stable

Этот REAME файл доступен на <a href="https://github.com/ShiftHackZ/OrderAutomizer/blob/master/README.md">Русском</a>

## Description
This application allows you to automate the process of formation of documents for the order, when there are many suppliers offering various products.

## История

The application was created at the end of 2017, for the tender department of the enterprise for the sale of medical goods, in order to simplify the process of classifying items for suppliers, with the ability to quickly select the necessary goods of a certain quantity, then export it to the MS Excel document.

The application was deployed on a server running Windows Server 2008 R2, accessed via Remote App technology.

In 2018, it became necessary to avoid manual editing of database files, as well as to limit access rights so that the operator could not change the database files. For this, the functionality of setting a password on the editor window on the API server side was implemented, and access to the database files for the operator account on the RemoteApp Server was set only for reading.

## Features
- This soft is written with C# (.NET Framework 4.0).
- The database is organized in a file form.
- Sorting products by vendors.
- Displaying the full name of the item with the input of quantity.
- Editiong the contents of a table document before export.
- Built-in database editor of suppliers and products.
- Setting a password for the database editor (server side).
- Export of the generated document to MS Excel.
- Statistics:
    - by the number of suppliers and goods in the database, with the calculation of the average value of commodity items per supplier.
    - by the number of issued orders and commodity items, with the calculation of the average number of items per order.

## Download

Latest release [v1.15] - <a href="https://dev.moroz.cc/desktop/OrderAutomizer/OrderAutomizer_v1.15.zip"><b>Download</b></a>

Current password, for opening editor window: **`testpassword`**

## Screenshots

![](https://github.com/ShiftHackZ/OrderAutomizer/raw/master/screenshots/1.PNG)

> Image 1. Main window

![](https://github.com/ShiftHackZ/OrderAutomizer/raw/master/screenshots/2.PNG)

> Image 2. Database editor window

![](https://github.com/ShiftHackZ/OrderAutomizer/raw/master/screenshots/3.PNG)

> Image 3. Changing of the product item

![](https://github.com/ShiftHackZ/OrderAutomizer/raw/master/screenshots/4.PNG)

> Image 4. Statistics on the number of goods and stored orders

![](https://github.com/ShiftHackZ/OrderAutomizer/raw/master/screenshots/5.PNG)

> Image 5. Authorization window (when opening editor)

![](https://github.com/ShiftHackZ/OrderAutomizer/raw/master/screenshots/6.PNG)

> Image 6. Document that was exported to MS Excel

### Developer
- Dmitriy Moroz
- dmitriy@moroz.cc
