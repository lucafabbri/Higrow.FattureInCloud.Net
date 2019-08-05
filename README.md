
# Higrow.FattureInCloud.Net
This is an unofficial implementation of the Fatture in Cloud Api for .Net C# Core 2.2. The package is based on the /v1 API version 0.9.14 [https://api.fattureincloud.it/v1/documentation/dist/](https://api.fattureincloud.it/v1/documentation/dist/)

## Information
We are integrating the whole app and the DTOs, hereafter the list of implemented services

 - [x] Anagrafica
 - [x] Prodotti
 - [x] Documenti
 - [x] Acquisti
 - [ ] Corrispettivi
 - [ ] Magazzino
 - [ ] Mail
 - [x] Info

## Installation
**Nuget**

Windows

    Install-Package Higrow.FattureInCloud.Net -Version 0.9.14.1

Linux/MacOsx

    dotnet add package Higrow.FattureInCloud.Net --version 0.9.14.1

## Setup
Endpoints are split in services in the Higrow.FattureInCloud.Net.Services as follow:

 - AnagraficaService
 - ProdottiService
 - DocumentiService 
 - AcquistiService
 - InfoService

To start using a Service you should enter your FattureInCloud api_uid and api_key, please go here to get yours 
[https://secure.fattureincloud.it/api](https://secure.fattureincloud.it/api)

**Includes**
    include Higrow.FattureInCloud.Net.Services
    include Higrow.FattureInCloud.Net.DTO
    include Higrow.FattureInCloud.Net.Constants

**Create a service**

    AnagraficaService service = new AnagraficaService();
    service.SetKeys("your_api_uid","your_api_key");

All Request and Response DTO have been mapped, exploring the service method you can easily build your queries and get.

**Example**

    //the library does not manage exception, don't forget to surrond with try catch
    try
    {
    	AnagraficaListaResult result = await service.Lista(Soggetto.CLIENTI, new AnagraficaListaRequest(){});
    }
    catch (Exception ex)
    {
    	//manage exception
    	Console.WriteLine(ex.Message);
    	Console.WriteLine(await service.LastResponse?.Content.ReadAsStringAsync()); //service.LastResponse contains the LastResponse, might be null if errors happened before any possible response
    }
