//specify the data source
List<int> scores = [75, 89, 95, 77, 82];



// Define the query expression
IEnumerable<int> scoreQuery =
from score in scores
where score > 80
select score;

// Exuecute the query and display the results
foreach (int i in scoreQuery)
{
    Console.WriteLine(i + " ");
}

