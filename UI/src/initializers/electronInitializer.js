const { app, BrowserWindow } = require('electron');
const path = require('path');

let win;
function createWin() {
    win = new BrowserWindow({ 
        width: 950,
        height: 650,
        webPreferences: { 
            nodeIntegration: true
        } 
    });
    win.loadFile(path.resolve(__dirname, '../../dist/index.html'));
};

app.on('ready', createWin);

app.on('window-all-closed', function () {
    // On macOS it is common for applications and their menu bar
    // to stay active until the user quits explicitly with Cmd + Q
    if (process.platform !== 'darwin') {
      app.quit()
    }
  });

