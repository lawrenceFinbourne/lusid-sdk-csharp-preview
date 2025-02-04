# Lusid.Sdk.Model.QuoteAccessMetadataRuleId
An identifier that uniquely identifies a set of Quote access control metadata.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | The platform or vendor that provided the quote, e.g. &#39;DataScope&#39;, &#39;LUSID&#39; etc. | [optional] 
**PriceSource** | **string** | The source or originator of the quote, e.g. a bank or financial institution. | [optional] 
**InstrumentId** | **string** | The value of the instrument identifier that uniquely identifies the instrument that the quote is for, e.g. &#39;BBG00JX0P539&#39;. | [optional] 
**InstrumentIdType** | **string** | The type of instrument identifier used to uniquely identify the instrument that the quote is for, e.g. &#39;Figi&#39;. | [optional] 
**QuoteType** | **string** | The type of the quote. This allows for quotes other than prices e.g. rates or spreads to be used. | [optional] 
**Field** | **string** | The field of the quote e.g. bid, mid, ask etc. This should be consistent across a time series of quotes. The allowed values are dependant on the specified Provider. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

