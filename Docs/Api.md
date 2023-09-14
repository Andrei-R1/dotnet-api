# Food App API

- [Food App API](#food-app-api)
  - [Create Food](#create-food)
    - [Create Food Request](#create-food-request)
    - [Create Food Response](#create-food-response)
  - [Get Food](#get-food)
    - [Get Food Request](#get-food-request)
    - [Get Food Response](#get-food-response)
  - [Update Food](#update-food)
    - [Update Food Request](#update-food-request)
    - [Update Food Response](#update-food-response)
  - [Delete Food](#delete-food)
    - [Delete Food Request](#delete-food-request)
    - [Delete Food Response](#delete-food-response)

## Create Food

### Create Food Request

```js
POST /foods
```

```json
{
    "name": "Paul Night",
    "description": "Join us for a healthy breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Create Food Response

```js
201 Created
```

```yml
Location: {{host}}/Foods/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Paul Night",
    "description": "Join us for a healthy breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Get Food

### Get Food Request

```js
GET /foods/{{id}}
```

### Get Food Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Paul Night",
    "description": "Join us for a healthy breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Update Food

### Update Food Request

```js
PUT /foods/{{id}}
```

```json
{
    "name": "Paul Night",
    "description": "Join us for a healthy breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Update Food Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Foods/{{id}}
```

## Delete Food

### Delete Food Request

```js
DELETE /foods/{{id}}
```

### Delete Food Response

```js
204 No Content
```
