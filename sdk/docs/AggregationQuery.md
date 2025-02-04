# Lusid.Sdk.Model.AggregationQuery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressKey** | **string** | The address that is the query to be made into the system. e.g. a Valuation/Pv or Instrument/MaturityDate | 
**Description** | **string** | What does the information that is being queried by the address mean. What is the address for. | 
**DisplayName** | **string** | The suggested name that the user would wish to put on to the returned information for visualisation in preference to the address. | 
**Type** | **string** | The available values are: String, Int, Decimal, DateTime, Boolean, ResultValue, Array, Map, Json | 
**ScalesWithHoldingQuantity** | **bool** | Is the data scaled when it is for, e.g. a holding in an instrument. A key example would be the difference between price and pv. The present value  of an instrument would scale with the quantity held. The price would be that for a hypothetical unit of that instrument, typically associated with the  contract size. | 
**SupportedOperations** | **string** | When performing an aggregation operation, what column type operations can be performed on the data. For example, it makes sense to sum decimals but  not strings. Either can be counted. With more complex types, e.g. ResultValues, operations may be linked to a semantic meaning such as the currency  of the result. In such cases the operations may be supported but context specific. For example, it makes sense to sum PVs in a single currency but not  when the currency is different. In such cases, an error would result (it being assumed that no fx rates for currency conversion were implicit in the context). | 
**LifeCycleStatus** | **string** | Within an API where an item can be accessed through an address or property, there is an associated status that determines  whether the item is stable or likely to change. This status is one of [Experimental, Beta, EAP, Prod,  Deprecated]. If the item is  deprecated it will be removed on or after the associated DateTime RemovalDate field. That field will not otherwise be set. | 
**RemovalDate** | **DateTimeOffset** | If the life cycle status is set to deprecated then this will be populated with the date on or after which removal of the address query will happen | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

