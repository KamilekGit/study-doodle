import React from 'react'
import './Dialogs.css'

import DialogsItem from './dialogsItem/DialogsItem'
import Message from './message/Message'

let ref = React.createRef()

function Dialogs(props) {
    let sendMessage = () => {
        props.sendMessage(ref.current.value)
    }
    return (
        <div className="dialogs">
              <div className="dialog">
                  {props.dialogNames.map((e)=> <DialogsItem name={e.name} id={e.id}/> )}
              </div>
              <div className="messages">
                  {props.messageItems.map((e)=> <Message message={e.message} id={e.id}/> )}                 
              </div>
              <div className="code">
                  <input type="text" placeholder="Enter your message"/>
                  <button onClick={sendMessage}>Отправить</button>
              </div>
            
        </div>
    )
  }
export default Dialogs