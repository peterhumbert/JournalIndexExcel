# JournalIndexExcel
A simple Excel macro for turning Category-Subcategory-Date data into an index for printing and placement in the back of a journal.

In meeting other entrepreneurial students around the U, I've noticed a common habit: we all carry small notebooks. 

These notebooks contain hundreds of notes spanning a wide variety of topics, and as the notebooks fill, they provide thorough, chronological reference material for their owners.

That presents a problem. Once the notebook is full, the owner moves onto a new notebook without a good &mdash; preferably offline &mdash; way of finding content in the old notebook.

That's where this macro is useful. The notebook owner simply adds a row to an Excel spreadsheet for each entry in their notebook (or, better yet, a row for each item in the entry that they might lookup later).

For example, the journal entry data

| Category  | Subcategory             | Date      |
| --------- | ----------------------- | :--------:|
| Idea      | StartUp Student Group   | 9/10/2017 |
| Project   | Airplaces               | 9/15/2017 |
| Milestone | AEM Scholarship         | 9/21/2017 |
| Idea      | Innovation Competition  | 9/23/2017 |
| StartUp   | Board Meeting           | 9/26/2017 |
| Project   | Airplaces               | 9/27/2017 |
| StartUp   | Mentoring Event         | 9/28/2017 |
| Project   | Undergraduate Research  | 10/2/2017 |
| StartUp   | Board Meeting           | 10/3/2017 |

would become

| Category  | Subcategory             | Date      |
| --------- | ----------------------- | :--------:|
| Idea      | Innovation Competition  | 9/23/2017 |
|           | StartUp Student Group   | 9/10/2017 |
| Milestone | AEM Scholarship         | 9/21/2017 |
| Project   | Airplaces               | 9/15/2017 |
|           |                         | 9/27/2017 |
|           | Undergraduate Research  | 10/2/2017 |
| StartUp   | Board Meeting           | 9/26/2017 |
|           |                         | 10/3/2017 |
|           | Mentoring Event         | 9/28/2017 |

With a few moments of additional formatting and preparation for printing, it's possible to add a proper, offline index to the back of your notebook.
