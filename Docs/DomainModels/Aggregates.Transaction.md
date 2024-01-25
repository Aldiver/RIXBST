# Transactions Domain

```csharp
class Transaction
{
    Transaction Create();

    void AddTransaction(Transaction transaction);
    void RemoveTransaction(Transaction transaction);
    //submit ?
    //cancel/revoke/delete?
}
```

```json
{
    "id": { "value": "40a415ae-7650-45cd-8446-1e5fd5d16c9e"},
    "name": "PR - Meals for Activity name",
    "description": "meals for conduct of Activity at Location",
    "requestType": {
        "name": "Procurement",
        "description": "procurement of meal for event",
        "group": 
            {
                "name": "Technical Operations Division",
                "description": "Description",
                "members": [
                    { "value": "00000000-0000-0000-0000-000000000000"},
                ],
            }
        },
    "document": "pr-meals-2024.pdf",
    "ownerId": { "value": "00000000-0000-0000-0000-000000000000" },
    "signatories": [
        {
            "id": { "value":"00000000-0000-0000-0000-000000000000" },
            "Remarks": "Done",
            "Status": "Signed",   
        }
    ],
    "createdDateTime": "Jan-18-2024",
    "updatedDateTime": "Jan-18-2024",
}
```