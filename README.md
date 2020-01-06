Create a digital Mad Libs game using ASP.NET Core MVC. 
Users should be presented with a form with fields for various parts of speech (nouns, adjectives, adverbs, exclamations, and so on). 
After filling out and submitting that form, they should navigate to a page containing a story that has used their provided words in its text.

- Begin small, gathering and using only a few key words.

- After completing a short Mad Libs with user-provided words, expand it further. Add new variables to the form and story.

- Additionally, try to format the story output in a visually-appealing way.

* Further Exploration: Consider allowing users to select from multiple Mad Libs themes, stories, or templates before being presented a form. Each different story should require a unique combination of words, and therefore have its own unique form. Hint: You can link to a different route by adding the route's path to a standard <a> tag. For instance, a Puppy() route with the route decorator [Route("/puppy-story")] could be accessed from another page with the link <a href="/puppy-story">Click here for puppies!</a>.