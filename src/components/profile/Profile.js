import React from 'react'
import './Profile.css'
import ProfileInfo from './profile_info/ProfileInfo'
import ava from '../../img/elon.jpg'
import Posts from './posts/Posts'
function Profile(props) {
    return (
        
  <div className='profile'>
    <ProfileInfo/>
    <Posts postsItems = {props.postsItems}/>
  </div>
        
    )
  }
export default Profile