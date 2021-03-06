```diff
- Tabwire closed the API to the public. They are no longer giving away API keys.
```

# R6TabApiWrapper
Api Wrapper for R6Tab Api

![enter image description here](https://img.shields.io/badge/Made%20With-C%23-blueviolet?style=for-the-badge)

<img alt="GitHub" src="https://img.shields.io/github/license/Cenngo/R6Tab.NET?style=flat-square"> <a href="https://www.nuget.org/packages/R6Tab.NET"><img alt="Nuget" src="https://img.shields.io/nuget/v/R6Tab.NET?logo=nuget&style=flat-square"></a> <a href="https://www.nuget.org/packages/R6Tab.NET"><img alt="Nuget" src="https://img.shields.io/nuget/dt/R6Tab.NET?color=blue&logo=nuget&style=flat-square"></a>

* Search Players by Name
* Search Players by Id
* Get LeaderBoards for Every Region and Platform
* Access Every Region Ranked Information within Its Respective Object
* Access Every Gamemode Information within Its Respective Object
* Get Rank Banners
* Get User Avatars

Api Keys are provided by TabWire. For further information about getting one please refer to https://github.com/Tabwire/R6Tab-API

## Getting Started
```csharp
var config = new R6Config()
{
   ApiKey = "xxxx-xxxx-xxxx-xxxx"
};
var client = new R6Client(config);

//Parsing By Name
var result = client.ParseByName("baiier", Platform.Uplay);

//Getting the Best Match from Username
var result = client.ParseByName("baiier", Platform.Uplay);
var player = result.FoundPlayers.Values.ElementAt(1);

//Parse by Id
var result = client.ParseById("9bd44bde-9c48-48ae-9c2b-4e11e4b16083");

///Getting Leaderboard
var leaderboard = client.GetLeaderboard(Platform.Uplay, Region.All);

//Update Player Info 
var result = client.UpdatePlayer("9bd44bde-9c48-48ae-9c2b-4e11e4b16083");
```

After the unfication of ranks accross regions, the overall ranked stats are currently stored in the NA sub-stats which renders EU and AS unnecessary.

Please use the NA stats to retrieve th overall ranked stats. Until the new version is released.

## In Progress
- [x] Decode Operator Ids
- [x] Get Top Operators in Each Category (Wins/Losses/Kills/Deaths/Play Time)
- [x] Get Color of the Rank Banner 
- [x] Auto Cache Avoidance
- [x] Get All Stats of Specific Operator

## Documentation
[Documentation](https://cenngo.github.io/R6Tab.NET/api/index.html) for the Api.
