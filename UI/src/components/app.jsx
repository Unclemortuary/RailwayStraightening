import React from 'react';
import ReactDOM from 'react-dom';

import AppContainer from './appContainer/appContainer.jsx';

const mount = () => {
    const element = document.getElementById('root');
    ReactDOM.render(<AppContainer />, element);
};

export default mount;