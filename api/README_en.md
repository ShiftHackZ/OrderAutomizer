# Order Automizer
###### v1.15 Stable

# API Documentation

## API Methods

- /access
- /editor_pass_enable
- /editor_pass_hash
- /latest
- /msg_messg
- /msg_title
- /version

## Description of the API Methods

### 1. /access

 **Available values**: allow, lock
 
 **Description**:
 - if the value is set to ** lock **, then at launch the application will display a dialog box with a header and a message, which are obtained from the methods ** / msg_title ** and ** / msg_messg **.
 - if set to ** allow ** or any other, the application runs in normal mode.

### 2. /editor_pass_enable

 **Available values**: 0, 1
 
 **Description**:
 - if the value is set to ** 1 ** then the dialog box with a password prompt will appear, while opening editor.
 - if the value is set to ** 0 ** the editor is started in the normal mode.

### 3. /editor_pass_hash

 **Description**: contains an MD5 hash sum for the password to be entered.
 
 **Requirements**: all characters must be uppercase.

### 4. /version

 **Description**: contains a line with the number of the latest version of the application.
 
 **Requirements**: the version must be specified in the format X.XX, where X is any integer.

### 5. /latest

 **Description**: contains a line with a direct link to download the latest version of the application.

### 6. /msg_title

 **Description**: contains a string with the message header, which is displayed when setting the ** lock ** value in the ** / access ** method.
 
 **Requirements:** cyrillic characters are not allowed.

7. /msg_messg

 **Description**: contains a string with the message body, which is displayed when setting the ** lock ** value in the ** / access ** method.
 
 **Requirements:** cyrillic characters are not allowed.

## Developer
- Dmitriy Moroz
- dmitriy@moroz.cc
