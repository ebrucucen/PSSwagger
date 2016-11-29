# PSSwagger

Tool to generate PowerShell Cmdlets using Swagger based specifications

## Syntax

Export-CommandFromSwagger -SwaggerSpecPath <string> -Path <string> -ModuleName <string> [-UseAzureCsharpGenerator] [<CommonParameters>]

Export-CommandFromSwagger -SwaggerSpecUri <uri> -Path <string> -ModuleName <string> [-UseAzureCsharpGenerator] [<CommonParameters>]

| Parameter | Description |
| --------- | ----------- |
| SwaggerSpecPath | Full Path to a Swagger based JSON spec|
| Path            | Full Path to a folder where the commands/modules are exported to |
| ModuleName      | Name of the module to be generated. A folder with this name will be created in the location specified by Path parameter |
| SwaggerSpecUri  | URI to the swagger spec |

## Usage

Note: Please run this steps on a Windows 10 Anniversary Update or Windows Server 2016 RTM and above.

1. Git clone this repository.

     ```code
    git clone https://github.com/PowerShell/PSSwagger.git
    ```

2. Ensure you AutoRest version 0.16.0 installed

   ```powershell
   Install-Package -Name AutoRest -Source https://www.nuget.org/api/v2 -RequiredVersion 0.16.0 -Scope CurrentUser
   ```
   
3. Ensure AutoRest.exe is in $env:Path

   ```powershell
   $env:path += ";$env:localappdata\PackageManagement\NuGet\Packages\AutoRest.0.16.0\tools"
   ```

4. Run the following in a PowerShell console from the directory where you cloned PSSwagger in:

   ```powershell
   Import-Module .\PSSwagger.psd1
   Export-CommandFromSwagger -SwaggerSpecUri https://github.com/Azure/azure-rest-api-specs/blob/master/arm-batch/2015-12-01/swagger/BatchManagement.json -Path C:\Temp\generatedmodule\ -ModuleName Generated.Azure.BatchManagement
   ```

After step 4, the module will be in `C:\Temp\GeneratedModule\Generated.Azure.BatchManagement` folder.

Before importing that module and using it, you need to import Generated.Azure.Common.Helpers module which is under PSSwagger folder.
