import React from 'react';
import { useState } from "react";
import './App.scss';
import ListApiAxios from './components/ListApiAxios/ListApiAxios';
import MyForm from './components/ClientForm/ClientForm';
import ListTherapist from './components/ListTherapist/ListTherapist';
import ListTurn from './components/ListTurn/ListTurn';

function App() {
return <div>
 {/* <MyForm></MyForm> */}
<ListApiAxios></ListApiAxios>
{/* <ListTurn></ListTurn> 
<ListTherapist></ListTherapist> */}
</div>
}

export default App;
