import React from 'react'
import { NavLink } from 'react-router-dom'




function Message(props) {
    return (
        <div className='message'>
            <p>{props.message}</p>
        </div>
    )
  }
export default Message