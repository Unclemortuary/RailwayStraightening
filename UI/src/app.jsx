import React from 'react';
import ReactDOM from 'react-dom';

const App = () => <span>Hello from react app!</span>;

const mount = () => {
    const element = document.getElementById('root');
    ReactDOM.render(<App />, element);
};

export default mount;