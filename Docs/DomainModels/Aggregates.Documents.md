# Domain Models

## Transactions ? 

```csharp
class Transaction
{
    Transaction Create();

    void AddTransaction(Transaction transaction);
    void RemoveTransaction(Transaction transaction);

}
```

```json
{
    "id": "40a415ae-7650-45cd-8446-1e5fd5d16c9e",
    "name": "PR - Meals for Activity name",
    "description": "meals for conduct of Activity at Location",
    "requestType": "Less 10k",
    "processDocumentsNotSure": [
        {
            "id": "00000000-0000-0000-0000-000000000000",
            "name": "TOD Route",
            "isDone": false,
            "routeDateTime": "Jan-18-2024",
            "userIds": [
                "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000",
                "00000000-0000-0000-0000-000000000000"
            ] 
        },
        {
            "id": "00000000-0000-0000-0000-000000000000",
            "name": "TOD Route",
            "isDone": false,
            "routeDateTime": "Jan-18-2024" 
        },
    ]
    "createdDateTime": "Jan-18-2024",
    "updatedDateTime": "Jan-18-2024",
    "ownerId": "00000000-0000-0000-0000-000000000000",
    "projectId": "00000000-0000-0000-0000-000000000000",
    "involvedId": [
        "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000",
        "00000000-0000-0000-0000-000000000000"
    ]
}
```