class BooksList extends React.Component {
    render() {
        const booksNodes = this.props.data.map(book =>
        (<div key={book.id}>
            UserId={book.userId};&nbsp;Title={book.title};
        </div>))
        return <div className="BooksList">{booksNodes}</div>;
    }
}

class App extends React.Component {

    constructor(props) {
        super(props);
        this.state = { data: [] };
        this.loadBooksFromRestService();
    }

    loadBooksFromRestService() {
        console.log("call => loadBooksFromRestService")        
        const restBooksUrl = "https://jsonplaceholder.typicode.com/todos/"
        const xhr = new XMLHttpRequest();
        xhr.open('get', restBooksUrl, true);
        xhr.onload = () => {
            const data = JSON.parse(xhr.response);
            console.log(data);
            this.setState({ data: data });
        };
        xhr.send();
    }

    render() {
        return (
            <div className="App">
                <BooksList key="booksListId" data={this.state.data} loadbooks={this.loadBooksFromRestService} />
            </div>
        );
    }
}

ReactDOM.render(
    React.createElement(App, null),
    document.getElementById('bookscontent'),
);