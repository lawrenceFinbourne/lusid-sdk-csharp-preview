# Lusid.Sdk.Model.AnnulSingleStructuredDataResponse
The response to a request to annul (delete) a set of structured data from Lusid. This might have been for market data or some other structured entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Value** | **DateTimeOffset** | The time at which the identifier was annulled | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

