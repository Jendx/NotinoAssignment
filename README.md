# NotinoAssigement

Demonstrate production-ready code in the form you would submit it to code review.

# Assignment
Estimated timeframe: 2h

## Create production-ready ASP.NET Core service app that provides API for storage and retrive documents in different formats

The documents are send as a payload of POST request in JSON format and could be modified via PUT verb.
The service is able to return the stored documents in different format, such as XML, MessagePack, etc.
It must be easy to add support for new formats.

It must be easy to add different underlying storage, like cloud, HDD, InMemory, etc.
Assume that the load of this service will be very high (mostly reading).
Demonstrate ability to write unit tests.

The document has mandatory field id, tags and data as shown bellow. The schema of the data field can be arbitrary.
POST http://localhost:5000/documents
Content-Type: application/json; charset=UTF-8
```json
{
    "id": "some-unique-identifier1",
    "tags": ["important", ".net"]
    "data": {
        "some": "data",
        "optional": "fields"
    }
}
```
GET http://localhost:5000/documents/some-unique-identifier1
Accept: application/xml
