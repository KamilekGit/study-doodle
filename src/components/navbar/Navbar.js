import React from "react"
import "./Navbar.css"
import {NavLink} from 'react-router-dom'
function Navbar(){
    return(
      <div className='navbar'>
        <NavLink to='/profile'>Profile</NavLink>
        <NavLink to='/messages'>Messages</NavLink>
        <NavLink to='/users'>Users</NavLink>
        <NavLink to='/dialog'>Dialog</NavLink>
      </div>
    )
  }
export default Navbar