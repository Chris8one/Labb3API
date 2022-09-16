# Labb3API
##My third school project in Entitiy Framework class with focus on API

1. - [x] Get all persons in the database
- https://localhost:44348/api/helion/persons/
---
2. - [x] Get all intrests that is connected to a given person
- https://localhost:44348/api/helion/interests/1 (The 1 in the url is the persons id to get the interests for)
---
3. - [x] Get all links that is connected to a given person
- https://localhost:44348/api/helion/links/1 (The 1 in the url is the persons id to get the links for)
---
4. - [x] Connect a person to a new interest
- https://localhost:44348/api/helion/newinterest/5 (The 5 in the url is the persons id to create a new interest for)

The JSON-text to fill in the interest info
```
{
    "interestTitle": "Problem Solving",
    "interestDescription": "Loves to problem solve.. there for programming fell right in place"
}
```
---
5. - [x] Add a new link to a given person and a given interest

- https://localhost:44348/api/helion/newlink/personid/5/interestid/9 (The 5 is the persons id, and the 9 is the interests id to add a link to)

The JSON-text to fill in the link info
```
{
    "linkDescription": "A video about solving code problems",
    "linkUrl": "https://www.youtube.com/watch?v=Dblfmk3ATeg"
}
```
---
Bonus
6. Add a new person to the database
- https://localhost:44348/api/helion/persons/
