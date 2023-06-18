
import './App.css';
import Header from './components/header/Header.js';
import Navbar from './components/navbar/Navbar.js';
import Profile from './components/profile/Profile.js';
import Dialogs from './components/dialogs/dialogs';
import Mess from './components/dialogs/dialog';
import { BrowserRouter, Routes, Route } from 'react-router-dom';

function App() {
  return (
    <div className='wrapper'>
      <BrowserRouter>
        <Header />
        <Navbar />
        <div className='wrapper-content'>
          <Routes>
            <Route path='/profile' Component={Profile} />
            <Route path='/dialogs' Component={Dialogs} />
            <Route path='/mess' Component={Mess} />
          </Routes>
        </div>


      </BrowserRouter >
    </div>
  );
}


export default App;
