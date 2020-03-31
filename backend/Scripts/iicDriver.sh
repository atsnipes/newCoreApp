echo "IIC Driver Running Cmd = { $1 }"

if [ "$1" = "ON" ]; then 
    echo "Turning On" 
    i2cset -y 1 0x10 0x01 0xFF
elif [ "$1" = "OFF" ]; then
    echo "Turning Off"
    i2cset -y 1 0x10 0x01 0x00
else
    echo "Cmd = { $1 } not recognized."  
fi;