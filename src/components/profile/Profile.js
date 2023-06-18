import React from "react"
import './Profile.css'
import ava from './elon.jpg'
import ava_min from './elon_mini.jpeg'
import Posts from "./posts/Posts"
function Profile() {
  return (
    <div className='profile'>
      <div className="me">


        <img src={require("./elon_mini.jpeg")} alt="profile mini photo" />
        <p>Elon Mask</p>

      </div>
      <Posts />
    </div>
  )
}
export default Profile