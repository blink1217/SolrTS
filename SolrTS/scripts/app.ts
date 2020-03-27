async function SearchMe() {

    var term = (<HTMLInputElement>document.getElementById("SearchBox")).value;
    const response = await fetch(
        "https://localhost:5001/lookup/" + term
    );

    var results = await response.json();

    document.getElementById("SearchResults").innerHTML = "Found " + results.name;

}

async function AddMeButton() {
    var name = (<HTMLInputElement>document.getElementById("AddMe")).value;
    const response = await fetch(
        "https://localhost:5001/add/" + name
    );
    var results = await response.json();

    if (results !== undefined) {
        document.getElementById("AddResults").innerHTML = "Added " + name;
    }
}