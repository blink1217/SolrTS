var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
function SearchMeButton() {
    return __awaiter(this, void 0, void 0, function* () {
        var term = document.getElementById("SearchBox").value;
        const response = yield fetch("https://localhost:5001/lookup/" + term);
        var results = yield response.json();
        document.getElementById("SearchResults").innerHTML = results.name;
    });
}
//# sourceMappingURL=app.js.map