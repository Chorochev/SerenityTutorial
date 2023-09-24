function MyApp() {
    return <h1>Hello, world!</h1>;
}

const container = document.getElementById('myAppReactRoot');
const root = ReactDOM.createRoot(container);
root.render(<MyApp />);