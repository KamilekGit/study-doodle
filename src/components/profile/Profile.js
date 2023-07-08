import React from 'react'
import './Profile.css'
import Posts from './posts/Posts'
import ProfileInfo from './profileInfo/ProfileInfo.js'

function Profile(props) {
    return (     
    <div className='profile'>
      <ProfileInfo/>
      <Posts postsItems={props.postsItems}/>
    </div>   
    )
  }
export default Profile