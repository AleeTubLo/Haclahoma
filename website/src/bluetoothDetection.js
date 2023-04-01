function onClickStart(){
    checkBlueTooth()
    alert('not done yet')
}

function checkBlueTooth(){
    if ('bluetooth' in navigator) {
        navigator.bluetooth.requestDevice({ acceptAllDevices: true })
          .then(device => {
            console.log(`Bluetooth device detected: ${device.name}`);
            // Do something with the device
          })
          .catch(error => {
            console.log(`Error detecting Bluetooth device: ${error}`);
          });
      } else {
        console.log('Web Bluetooth API is not supported in this browser.');
      }
}