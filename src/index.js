import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';

let postsItems = [
  { message: 'Hi, world', likes: 1 },
  { message: 'I`m Elon Mask, really', likes: 2 },
  { message: 'give me bitcoins', likes: 3 }
]

let messageItems = [{ message: 'Hi!', id: 1 },
{ message: 'Go on Mars', id: 2 },
{ message: 'Wheres my chip', id: 3 }]

let dialogNames = [{ name: "Ivan Ivanov", id: 1 },
{ name: 'Ilon Mask', id: 2 },
{ name: 'Bill Gates', id: 3 }]

ReactDOM.render(
  <React.StrictMode>
    <App
      postsItems={postsItems}
      messageItems={messageItems}
      dialogNames={dialogNames} />
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
