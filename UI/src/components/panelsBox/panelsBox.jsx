import React from 'react';
import Header from '../header/header.jsx';
import Panel from '../panel/panel.jsx';

const PanelsBox = () => (
    <div className="panelsBox">
        <Header />
        <Panel id="Standart" label="Эталон" />
        <Panel id="Measured" label="Измеренные" />
        <Panel id="Calculated" label="Конечные" />
    </div>
);

export default PanelsBox;