
// Header
var search = document.querySelector(".search")
var X_search = document.querySelector(".X_search")
var IconSearch = document.getElementById("IconSearch")
var project = document.querySelector(".projects")
var settings = document.querySelector(".settings")
var input = document.querySelector(".search_title")
var nav_container_1 = document.querySelector(".nav_container_1")
const click_X_search = () => {
    search.removeAttribute("style");
    //search.style.removeProperty("height");
    nav_container_1.style.width = "8rem";
    project.style.display = "block";
    settings.style.display = "block";
    input.style.display = "none";
    //IconSearch.style.removeProperty("position");
    IconSearch.removeAttribute("style");
    X_search.style.display = "none";
}
X_search.addEventListener("click", click_X_search);

document.getElementById("NotificationsIcon").addEventListener("click", () => {
    //alert("check")
    document.getElementById("Notifications").classList.toggle("Action");
})


const click_search = () => {
    search.style.cssText = `
            height: 3rem;
            width: 15rem;
        `
    nav_container_1.style.width = "fit-content";
    project.style.display = "none";
    settings.style.display = "none";
    input.style.cssText = `
            display: block;
        `
    IconSearch.style.cssText = `
            position: absolute;
            font-size: 1rem;
            width: 2rem !important;
            border: 2px solid black;
            height: 2rem;
        `
    X_search.style.display = "block";
}
IconSearch.addEventListener("click", click_search);

var menuIcon = document.getElementById("menuIcon");
var Menu_List = document.querySelector(".Menu_List");
const click_menu = () => {
    menuIcon.classList.toggle("fa-bars");
    menuIcon.classList.toggle("fa-x");
    Menu_List.classList.toggle("active");
}
menuIcon.addEventListener("click", click_menu);

document.querySelectorAll(".Dashboard, .StoreManagement, .Product, .Staff, .Order, .Report").forEach(
    item => {
        item.addEventListener("click", () => {
            //alert("check");
            let id = item.classList[1];
            document.getElementById("column-" + id).classList.toggle("active");
        });
    }
)
Menu_List.addEventListener("mouseleave", () => {
    if (!Menu_List.classList.contains("active")) {
        document.querySelectorAll(".column.active").forEach(c => c.classList.remove("active"));
    }
});
const observer = new MutationObserver(() => {
    if (!Menu_List.classList.contains("active")) {
        document.querySelectorAll(".column.active").forEach(c => c.classList.remove("active"));
    }
})
observer.observe(Menu_List, { attributes: true, attributeFilter: ['class'] });

