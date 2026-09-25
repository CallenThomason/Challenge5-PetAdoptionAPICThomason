## Callen Thomason
9/25/2026
Challenge #3 - Pet Adoption API
I built my first database using CRUDE operations and SQLite. I also created my first soft delete. All I did was create a IsDeleted and use a put to update the value to true. My restore method does the same thing, but turns the value to false. I had to figure out .SaveChanged() to get the values to save to my database. I didn't have it at first, so by database wasn't being saved. 
-----------Day Two--------------
I changed adoptpet and restorepet to patches, and removepet to a delete. I created a staff services, api, and database. I was able to change the amount that someone makes by using a HasValue. I quickly figured out that NullOrWhiteSpace does not work for int. 
Peer Reviewer:
Review:



 //       {
    //     "Id" : 1,
    //    "FirstName" : "Isaiah",
    //     "LastName" : "Ferguson",
    //   "Email" : "FootSaiah@Gmail.com",
    //   "Salary" : 1000000,
    //     "JobPosition" : "Bee Keeper",
    //    "IsWorking" : true
    // }