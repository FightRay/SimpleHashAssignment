# SimpleHash .NET
Welcome to the SimpleHash code repository.
Just a .NET Core API project with an POST endpoint and a hash function.

## Project requirements
```
- Visual Studio 2019
- .NET 5.0
```

## Hash Algorithm
SimpleHash is a hash function which takes an input and produces a 256-bit (32-byte) hash value.

Hash values are impossible to reverse since many input combinations can result in the same value, for example in this case, the string input '!!' will produce the same hash value as 'B' (without single quotes) - '01F07C1F07C1F07C7FFFFFFFFFFFFFBD0000000001F07C1F000000007FFFFFBD'.

## API Example
Endpoint '/hash' requires a key named 'input' with a string value.

It returns an object with the keys 'status' (boolean), indicating whether the operation is successful, and 'output' (string) containing the hashed value.

Sending a POST request with the key 'input', and value 'assignment'.
```
https://API_URL/hash
{ input: "assignment" }
```
Outputs the following:
```
{
    "status": true,
    "output": "001E500B5E0443417FFFFFFFFFFFFBC600000000001E500B000000007FFFFBC6"
}
```
Fallback, when input string is empty/null:
```
{
    "status": false,
    "output": "Input string cannot be empty!"
}
```
