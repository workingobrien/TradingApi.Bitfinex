TradingApi.Bitfinex
===================

This is a Bitfinex Exchange wrapper written in C#.

Why? 
I thought it would be a good learning experience and I hoped it would add value to others who want to trade on Bitfinex. 
It seemed connecting to Bitfinex was difficult with the instructions from the site. I want to create an assembly that would 
expose all the functionality one of the better btc exchanges had to offer. If you feel this offers value, I would ask 
you to donate: 16nKuxZ11MxY6qvoJuCzNm1hDVsUvnH4t5

Instructions: 
You should be able to add references to the "Trading.Api.Bitfinex.dll" and the "Trading.Api.ModelObjects.dll" to a form/web 
application. The constructor for the BitfinexApi class takes two string parameters to connect (ApiSecret and ApiKey). The 
instructions on the Bitfinex site are relatively straight forward. 

The "Trading.Api.ModelObjects.dll" has all of the encapsulated return types when you make a call to Bitfinex. A number of helper Enums exist int this assembly to make 
passing in the currency and/or pair you want to trade easier. 

Each Api call has two ways of returning data. 1. A simple 
function that returns an encapsulated type (public BitfinexOrderBookGet GetOrderBook(BtcInfo.PairTypeEnum pairType)). 2. An 
exposed event to provide callback returns of the encapsulated type (public event OrderBookMsgHandler OrderBookMsg;). If you 
are working in multiple projects and/or threads the events should be easier to process the data returned from the Api calls 
to Bitfinex.

I've also attached another assembly called "Cob.TradingApps.BtcData.dll." This is a simple assembly that will periodically 
poll for price updates for a specific pair. This is mostly a proof of concept to pull pair data from Bitfinex. Additionally, 
against my better judgment I have also attached the simple form project I used for testing. This is called "TradingCoins." 
Its only value is that you can specifically test all the functionality Bitfinex has to offer on this dopey form application. 
I have no desire to support the "TradingCoins" form.

3rd party dlls: 
log4net.dll (the App.config has the proper configuration) - 2.0.3 
RestSharp.dll - 104.5.0
Newtonsoft.Json.dll - 6.0.5

If you have any questions or wish to collaborate on other btc projects please email me atworkingobrien@gmail.com. I spent 
a reasonable amount of time on this project in hopes it adds value to someone who wants to trade more effectively on 
bitfinex. Please donate if you feel I was able to add value for you: 16nKuxZ11MxY6qvoJuCzNm1hDVsUvnH4t5.


