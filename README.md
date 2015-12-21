#Challenge #6 (due 12/31/2015): Guess the Gifts (courtesy codewars.com)
Kids these days are getting so high tech that even something as simple as guessing which gifts they’re going to get has already have been solved by technology.

##Description
It's Christmas! You had to wait the whole year for this moment. You can already see all the presents under the Christmas tree, but you have to wait for the next morning in order to unwrap them. You really want to know what's inside those boxes, but as a clever child, you can do your assumptions already.

You know you were a good child this year, so you may assume that you'll only get things from your wishlist. You see those presents, you can lift them, and you can shake them a bit. Now you can make you assumptions about what you'll get.

You will be given a wishlist (array), containing all possible items. Each object has the following structure:
```{name: "toy car", size: "medium", clatters: "a bit", weight: "medium"}```

You also get a list of presents (array), you see under the Christmas tree, which have the following format each:
```{size: "small", clatters: "no", weight: "light"}```

Your task is to create a list of all possible presents you might get.

Here are the rules:
* Possible values for size: small, medium, large
* Possible values for clatters: no, a bit, yes
* Possible values for weight: light, medium, heavy

* The return value must be an array of the names of items from your wishlist, e.g. ["Toy Car", "Card Game"]
* Don't add any item more than once to the result
* The order of names in the returned array doesn't matter
* It's possible that multiple items from your wish list will have the same attribute values. If they match the attributes of one of the presents, add all of them.

Example:
```var wishlist = [
    {name: "Mini Puzzle", size: "small", clatters: "yes", weight: "light"},
    {name: "Toy Car", size: "medium", clatters: "a bit", weight: "medium"},
    {name: "Card Game", size: "small", clatters: "no", weight: "light"}
];```

```var presents = [
    {size: "medium", clatters: "a bit", weight: "medium"},
    {size: "small", clatters: "yes", weight: "light"}
];```

```guessGifts(wishlist, presents); // must return ["Toy Car", "Mini Puzzle"]```

##Bonus Entry
We want this program to be extensible and meet SOLID standards.  Add another optional attribute, giver, which in the case of the presents lists the name of the person the present is from, and in the case of the wish list, the person from whom you were requesting the gift.  Add this attribute in such a way that none of your core program logic has to be modified, just newly added objects.

##Submission Instructions
GitHub repo: https://github.com/STGCodeChallenges/Q4-2015-Challenge-06

Google Form (to be filled out upon completion of challenge): https://docs.google.com/a/stgconsulting.com/forms/d/1cHyYb3NYejHOsGeRg98n_Nvx3FSwiuLa3BUq6SEL8j4/viewform?usp=send_form
