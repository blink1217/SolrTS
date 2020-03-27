async function SearchMeButton() {

    var term = (<HTMLInputElement>document.getElementById("SearchBox")).value;
    const response = await fetch(
        "https://localhost:5001/lookup/" + term
    );

    var results = await response.json();

    document.getElementById("SearchResults").innerHTML = results.name;

}