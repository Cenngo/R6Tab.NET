# R6TabApiWrapper
Api Wrapper for R6Tab Api

![enter image description here](https://img.shields.io/badge/Made%20With-C%23-blueviolet?style=for-the-badge)

<img alt="GitHub" src="https://img.shields.io/github/license/Cenngo/R6TabApiWrapper?style=flat-square"> <a href="https://www.nuget.org/packages/R6Tab.NET"><img alt="Nuget" src="https://img.shields.io/nuget/v/R6Tab.NET?logo=nuget&style=flat-square"></a>

* Search Players by Name
* Search Players by Id
* Get LeaderBoards for Every Region and Platform
* Access Every Region Ranked Information within Its Respective Object
* Access Every Gamemode Information within Its Respective Object
* Get Rank Banners
* Get User Avatars

## Getting Started
```csharp
var client = new R6Client();

//Parsing By Name
var result = client.ParseByName("baiier", Platform.Uplay);

//Parse by Id
var result = client.ParseById(9bd44bde-9c48-48ae-9c2b-4e11e4b16083);

///Getting Leaderboard
var leaderboard = client.GetLeaderboard(Platform.Uplay, Region.All);

//Update Player Info 
var result = client.UpdatePlayer(9bd44bde-9c48-48ae-9c2b-4e11e4b16083);
```

## In Progress
- [ ] Decode Operator Ids
- [ ] Get Top Operators in Each Category (Wins/Losses/Kills/Deaths/Play Time)
- [ ] Get Color of the Rank Banner 
