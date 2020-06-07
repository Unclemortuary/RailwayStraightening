import React from 'react';

const createInputId = (mainId, inputNumber) => `${mainId}${inputNumber}`;

const Panel = ({ id, label }) => (
    <div>
        <span>{label}</span>
        <div className="inputs">
            <input id={createInputId(id, 1)} type="number" min="0" max="1000"/>
            <input id={createInputId(id, 2)} type="number" min="0" max="1000"/>
            <input id={createInputId(id, 3)} type="number" min="0" max="1000"/>
            <input id={createInputId(id, 4)} type="number" min="0" max="1000"/>
            <input id={createInputId(id, 5)} type="number" min="0" max="1000"/>
            <input id={createInputId(id, 6)} type="number" min="0" max="1000"/>
            <input id={createInputId(id, 7)} type="number" min="0" max="1000"/>
            <input id={createInputId(id, 8)} type="number" min="0" max="1000"/>
            <input id={createInputId(id, 9)} type="number" min="0" max="1000"/>
            <input id={createInputId(id, 10)} type="number" min="0" max="1000"/>
            <input id={createInputId(id, 11)} type="number" min="0" max="1000"/>
        </div>
    </div>
);

export default Panel