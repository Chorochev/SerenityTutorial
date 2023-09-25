let currentTodoId = 1;

const getCurrentTodoId = function () {
    currentTodoId++;
    //console.log(currentTodoId);
    getTodoByID(currentTodoId, 'currentTodoDiv');    
}

const getTodoByID = function (todoid, divid) {
    const restBooksUrl = "https://jsonplaceholder.typicode.com/todos/" + todoid
    const xhr = new XMLHttpRequest();
    xhr.open('get', restBooksUrl, true);
    xhr.onload = () => {
        const data = JSON.parse(xhr.response);
        //console.log(data);
        document.getElementById(divid).innerText = "ID=" + data.id + ";  UserId=" + data.userId + ";  Title=" + data.title + ";";     
    };
    xhr.send();
}

class BooksList extends React.Component {
    render() {
        const booksNodes = this.props.data.map(book =>
        (<div key={book.id}>
            ID={book.id};&nbsp;UserId={book.userId};&nbsp;Title={book.title};
        </div>))
        return (
            <div className="BooksList">
                <button className="buttonChangeTodo" onClick={getCurrentTodoId}>Get Next Todo</button>
                <b><p id="currentTodoDiv" className="CurrentTodo"></p></b>
                <br/>
                <div className="TodoList">{booksNodes}</div>
            </div>);
    }
}

class App extends React.Component {

    constructor(props) {
        super(props);
        this.state = { data: [] };
        this.loadBooksFromRestService();
    }

    loadBooksFromRestService() {
        //console.log("call => loadBooksFromRestService")
        const restBooksUrl = "https://jsonplaceholder.typicode.com/todos/"
        const xhr = new XMLHttpRequest();
        xhr.open('get', restBooksUrl, true);
        xhr.onload = () => {
            const data = JSON.parse(xhr.response);
            //console.log(data);
            this.setState({ data: data });
        };
        xhr.send();
    }

    render() {
        return (
            <div className="App">
                <BooksList key="booksListId" data={this.state.data} />
            </div>
        );
    }
}

ReactDOM.render(
    React.createElement(App, null),
    document.getElementById('bookscontent'),
);