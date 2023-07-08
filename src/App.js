  import React from 'react'
  import './App.css'
  import Header from'./components/header/Header.js'
  import Navbar from './components/navbar/Navbar.js'
  import Profile from './components/profile/Profile.js'
  import Dialogs from './components/dialogs/Dialogs.js'
  import {BrowserRouter, Route, Switch} from 'react-router-dom'

  

  function App(props) {
    return (
      
        <div className="wrapper">
          <BrowserRouter> 
            <Header/>
            <Navbar/>
            {/* Нужно поставить react-router-dom ^5.2.0 чтобы switch работал. Или ^6 что-бы вместо него рабоатл Routes. Но так, как в методичке сейчас рабоать не будет.*/}
            <Switch>
              <Route exact path='/'  component={Profile}/>
              <Route exact path='/profile'  render = {()=> <Profile postsItems = {props.postsItems}/>} />
              <Route exact path='/dialogs'  render = {()=> <Dialogs dialogNames={props.dialogNames} messageItems={props.messageItems} />}/>
            </Switch>
          </BrowserRouter> 
        </div>  
    )
  }
export default App