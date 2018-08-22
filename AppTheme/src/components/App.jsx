import React, { Component, Fragment } from 'react'
import { Header, Footer } from './layouts'
import Message from './Message'


export default class App extends Component {
  render() {
    return (
      <Fragment>
        <Header />
        <Message />
        <Footer />
      </Fragment>
    );
  }
}