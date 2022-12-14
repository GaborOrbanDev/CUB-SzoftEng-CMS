const displayDate = () => {
    let d = new Date()
    document.querySelector("i").textContent = d.toLocaleDateString("hu-HU")

}

const article = (id) => {
    fetch(`api/article/${id}`)
        .then(
            response => response.json()
        )
        .then(
            data => {
                console.log(data)
                let div = document.createElement("div")
                div.classList.add("article")
                div.innerHTML = `
                            <h3>${data.title}</h3>
                            <span>${data.column}</span>
                            <p>${data.text}</p>
                        `
                document.querySelector(".article").appendChild(div)
                document.querySelector(".newses").style.display = "none"
            }
        )
}

const displayAllNews = (datas) => {
    for (let news of datas) {
        let div = document.createElement("div")
        div.classList.add("news")
        div.innerHTML = `
                    <h2 onclick="article(${news.id})">${news.title}</h2><span>${news.column}</span>
                `
        document.querySelector(".newses").appendChild(div)
    }
}

const newses = () => {
    fetch('/api/all')
        .then(
            response => response.json()
        )
        .then(
            datas => displayAllNews(datas)
        )
    document.querySelector(".newses").style.display = "flex"
    document.querySelector(".newses").innerHTML = ""
    document.querySelector(".article").innerHTML = ""
}

newses()
setInterval(displayDate(), 1000)