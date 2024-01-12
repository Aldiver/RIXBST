# RIXBST Portal

- [RIXBST PORTAL API](#rixbst-portal-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register request](#register-request)
            - [Register response](#register-response)
        - [Login](#login)
            - [Login request](#login-request)
            - [Login response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

### Register Request

```json
{
    "firstName": "Aldiver",
    "LastName": "Alcoriza",
    "email": "aldiver@email.com",
    "password": "strongpassword",
}
```
### Register Response

```js
200 OK
```

```json
{
    "id": "40a415ae-7650-45cd-8446-1e5fd5d16c9e",
    "firstName": "Aldiver",
    "lastName": "Alcoriza",
    "email": "aldiver@email.com",
}
```

### Login

```js
POST {{host}}/auth/login
```

### Login Request

```json
{
    "email": "aldiver@email.com",
    "password": "strongpassword",
}
```
### Login Response

```js
200 OK
```

```json
{
    "id": "40a415ae-7650-45cd-8446-1e5fd5d16c9e",
    "firstName": "firstName",
    "lastName": "lastName",
    "email": "aldiver@email.com",
    "token": "token-test",
}
```

