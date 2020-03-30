echo "IIC Driver Running Cmd = { $1 }"

if [ "$1" = "ON" ]; then 
    echo "Turning On" 
elif [ "$1" = "OFF" ]; then
    echo "Turning Off"
else
    echo "Cmd = { $1 } not recognized."  
fi;