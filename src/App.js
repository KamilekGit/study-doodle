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
            <Switch>
              <Route exact path='/' component={Profile} />
              <Route exact path='/profile' render = {()=> <Profile postsItems = {props.postsItems}/>}  />
              <Route exact path='/dialogs' render = {()=> <Dialogs dialogNames={props.dialogNames} messageItems={props.messageItems} />}/>

            </Switch>
          </BrowserRouter> 
        </div>  
    )
  }
export default App