# Lusid.Sdk.Model.InstrumentPaymentDiary
A payment diary containing all the cashflows on a single instrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdType** | **string** | The identifier type of the instrument. | [optional] 
**InstrumentId** | **string** | The identifier for the instrument. | [optional] 
**InstrumentScope** | **string** | The scope of the instrument. | [optional] 
**Version** | [**Version**](Version.md) |  | [optional] 
**Legs** | [**List&lt;InstrumentPaymentDiaryLeg&gt;**](InstrumentPaymentDiaryLeg.md) | Aggregated sets of Cashflows. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

