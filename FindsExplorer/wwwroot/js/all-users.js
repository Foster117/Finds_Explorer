function getAllUsers() {
    let allUsersRequest = new XMLHttpRequest();
    allUsersRequest.open("GET", "/Users/GetAllUsers?offset=0", true);
    allUsersRequest.send();
    allUsersRequest.onreadystatechange = () => {
        if (allUsersRequest.status == 200) {
            document.getElementById("users-container").innerHTML = allUsersRequest.responseText;
        }
    };
}

function getUsersByName() {
    let name = document.getElementById("searchInput").value;
    if (name === "") {
        return;
    }
    let usersByNameRequest = new XMLHttpRequest();
    usersByNameRequest.open("GET", "/Users/FindByName?name=" + name, true);
    usersByNameRequest.send();
    usersByNameRequest.onreadystatechange = () => {
        if (usersByNameRequest.status == 200) {
            document.getElementById("users-container").innerHTML = usersByNameRequest.responseText;
        }
    };
}
window.addEventListener("load", getAllUsers);
document.getElementById("findByNameButton").onclick = getUsersByName;