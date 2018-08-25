import React, { Component, Fragment } from 'react'
import { SiteHeader, Footer } from './layouts'


export default class App extends Component {
  render() {
    return (
      <Fragment>
        <SiteHeader />
        <Footer />
      </Fragment>
    );
  }
}