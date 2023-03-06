# Ring0 Driver Loader

Adopted from clamchowder's  MsrUtil tool (Performance Counter Reader) found at github.com/clamchowder/MsrUtil

I admit I'm not great at C# or Windows development in general, so I'm not 100% on having done things the right way but it seems to be functional. This tool is used to load the WinRing0 driver so that I can use it in C code.

# THIS SOFTWARE IS CONSIDERED EXPERIMENTAL. 

## Building
Open the sln in Visual Studio, hit build.

## Running
The code needs to be run as admin to function. 
It takes arguments: 
> 'load' loads the driver (currently no way to unload though without restarting)
> 'unload' doesn't work (I need to implement it but I don't have time)
> 'keep_open' loads the driver and keeps it open until you give it any input (Enter key press) and then unloads and exits. This is the recommended mode.
Keep_open is the default for no arguments. 
To run either run from an admin privileges cmd instance or right click, run as admin for keep_open. It needs admin privileges to use the winring0 driver.
