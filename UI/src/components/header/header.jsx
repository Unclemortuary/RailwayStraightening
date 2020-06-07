import React from 'react';

const Header = () => (
    <div className='accuracyContainer'>
        <span>Погрешность :</span>
        <input id='accuracy' type="number" min="0" max="1000"></input>
    </div>
);

export default Header;