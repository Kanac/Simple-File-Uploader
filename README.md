# Simple-File-Uploader

Simple File Uploader Web Server with an API endpoint that accepts files

## Running it
1. Open the .sln file in Visual Studio
2. Run the application by pressing IIS Express
3. The API endpoint will be available at https://localhost:44345/api/upload/file

# Sample Javascript API call
```
public async uploadBlob(blob: Blob) {
    var formdata = new FormData();
    formdata.append('file', blob, 'test.mp4');

    var requestOptions = {
        method: 'POST',
        body: formdata
    };

    fetch('https://localhost:44345/api/upload/file', requestOptions)
        .then(response => response.text())
        .then(result => console.log(result))
        .catch(error => console.log('error', error));
}
```

# File Location
The file will be saved in the given format {GUID()} {FileName} and will be located in the FileUpload folder.
